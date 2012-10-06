using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using GlobalTests.Model;
using System.Collections.Generic;
using FluentAssertions;
using GlobalTests.Data;
using System.Linq;

namespace GlobalTests.Topics.LinqToObjects
{
    [TestClass]
    public class SelectManyTests
    {
        [TestMethod]
        public void TestingSelectMany()
        {
            // cross joins

            var d = new DataRepositoryDummy();
            var pets = d.GetPets();
            var people = d.GetPeopleWithPets();

            var q = from pet in pets
                    from person in people
                    select new { Person = person, Pet = pet };
            q.Should().HaveCount(24);

            var q1 = pets.SelectMany(x => people, (pet, person) => new { Pet = pet, Person = person });
            q1.Should().HaveCount(24);
        }

        [TestMethod]
        public void testing_select_many_with_linq_to_sql_objects()
        {
            var ctx = new PubsDataContext();

            var q = from e in ctx.employee
                    from j in ctx.jobs
                    orderby e.fname, e.lname, j.job_desc
                    select new
                    {
                        Employee = e,
                        Job = j
                    };

            Console.WriteLine(q);
            q.Should().NotBeNull().And.NotBeEmpty();
            foreach (var item in q)
            {
                Console.WriteLine(
                    string.Format(
                    "Employee: {0} - Job: {1}",
                    item.Employee.fname + " " + item.Employee.lname,
                    item.Job.job_desc
                    ));
            }

            var r = ctx.employee.OrderBy(x => x.fname).ThenBy(x => x.lname).SelectMany(
                x => ctx.jobs.OrderBy(c => c.job_desc),
                (x, y) => new
                {
                    Employee = x,
                    Job = y
                });

            Console.WriteLine(r);
            r.Should().NotBeNull().And.NotBeEmpty();
            foreach (var item in r)
            {
                Console.WriteLine(
                    string.Format(
                    "Employee: {0} - Job: {1}",
                    item.Employee.fname + " " + item.Employee.lname,
                    item.Job.job_desc
                    ));
            }
        }
    }
}
