using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalTests.Data;
using GlobalTests.Model;
using System.Linq;
using FluentAssertions;

namespace GlobalTests.Topics.LinqToObjects
{
    [TestClass]
    public class GroupByTests
    {
        [TestMethod]
        public void GroupByAge()
        {
            var co = new DataRepositoryDummy().GetCountries().SelectMany(x => x.People);

            var q = from c in co
                    group c by c.Age;
            q.Should().HaveCount(5);

            var q1 = co.GroupBy(key => key.Age, result => result);
            q1.Should().HaveCount(5);
        }

        [TestMethod]
        public void GroupByLanguage()
        {
            var co = new DataRepositoryDummy().GetCountries().SelectMany(x => x.People).SelectMany(x => x.LanguagesSpoken);

            var q = co.GroupBy(x => x, x => x, (key, languages) => new { Key = key, Languages = languages });
            q.Should().HaveCount(5);

            var q1 = from c in co
                     group c by c into grouped
                     select new { Key = grouped.Key, Languages = grouped };
            q1.Should().HaveCount(5);
        }

        [TestMethod]
        public void testing_simple_group_by_with_linq_to_sql_objects()
        {
            var ctx = new PubsDataContext();

            var q = from e in ctx.employee
                    group e by e.job_id;

            q.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(13);
            Console.WriteLine(q);
            foreach (var item in q)
            {
                Console.WriteLine(string.Format(
                    "Job ID: {0} - Number of employees: {1}",
                    item.Key,
                    item.Count()));
            }

            var w = ctx.employee.GroupBy(
                x => x.job_id,
                x => x);

            w.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(13);
            Console.WriteLine(w);
            foreach (var item in w)
            {
                Console.WriteLine(string.Format(
                    "Job ID: {0} - Number of employees: {1}",
                    item.Key,
                    item.Count()));
            }
        }

        [TestMethod]
        public void testing_composite_group_by_using_linq_to_sql_objects()
        {
            var ctx = new PubsDataContext();

            var q = from e in ctx.employee
                    join j in ctx.jobs
                    on e.job_id equals j.job_id
                    group
                    new
                    {
                        Employee = e,
                        Job = j
                    }
                    by j.job_desc into grouped
                    orderby grouped.Key
                    select grouped;

            q.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(13);
            Console.WriteLine(q);
            foreach (var item in q)
            {
                Console.WriteLine(string.Format(
                    "Job: {0} - Number of employees: {1}",
                    item.Key,
                    item.Count()));

                foreach (var item2 in item)
                {
                    Console.WriteLine(string.Format(
                        "\tEmployee name: {0}",
                        item2.Employee.fname + " " + item2.Employee.lname));
                }
            }

            var w = ctx.employee.Join(
                ctx.jobs,
                x => x.job_id,
                x => x.job_id,
                (x, y) => new
                {
                    e = x,
                    j = y
                }).GroupBy(x => x.j.job_desc, x => new
                {
                    Employee = x.e,
                    Job = x.j
                }).OrderBy(x => x.Key);

            w.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(13);
            Console.WriteLine(w);
            foreach (var item in w)
            {
                Console.WriteLine(string.Format(
                    "Job: {0} - Number of employees: {1}",
                    item.Key,
                    item.Count()));

                foreach (var item2 in item)
                {
                    Console.WriteLine(string.Format(
                        "\tEmployee name: {0}",
                        item2.Employee.fname + " " + item2.Employee.lname));
                }
            }
        }
    }
}
