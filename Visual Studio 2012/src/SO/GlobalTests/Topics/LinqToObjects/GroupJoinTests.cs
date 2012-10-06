using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalTests.Model;
using System.Linq;
using System.Collections.Generic;
using GlobalTests.Data;
using FluentAssertions;
using System.Diagnostics;

namespace GlobalTests.Topics.LinqToObjects
{
    [TestClass]
    public class GroupJoinTests
    {
        [TestMethod]
        public void GroupJoinTesting()
        {
            // left joins

            var d = new DataRepositoryDummy();
            var people = d.GetPeopleWithPets();
            var pets = d.GetPets();

            var leftJoin = people.GroupJoin(pets, x => x.Name, x => x.Owner.Name, (key, thePets) => new
                {
                    Owner = key,
                    Pets = thePets
                });
            leftJoin.Should().HaveCount(4);

            var leftJoinEsteroids = from p in people
                                    join pe in pets
                                    on p.Name equals pe.Owner.Name
                                    into petsTmp
                                    select new { Owner = p, Pets = petsTmp };
            leftJoinEsteroids.Should().HaveCount(4);

            var q = leftJoin.First(x => x.Owner.Name == "Paul");
            q.Pets.Count().Should().Be(0);

            leftJoinEsteroids.First(x => x.Owner.Name == "Paul").Pets.Should().HaveCount(0);
        }

        [TestMethod]
        public void testing_left_joins_with_linq_to_sql_objects()
        {
            var ctx = new PubsDataContext();

            var q = from j in ctx.jobs
                    join e in ctx.employee
                    on j.job_id equals e.job_id
                    into leftJoined
                    select new
                    {
                        Job = j,
                        EmployeesCount = leftJoined.Count(),
                        Employees = leftJoined
                    } into u
                    orderby u.EmployeesCount, u.Job.job_desc
                    select u;

            Console.WriteLine(q);
            q.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(15);
            foreach (var item in q)
            {
                Console.WriteLine(
                    string.Format(
                    "{0} - Number of employees: {1}",
                    item.Job.job_desc,
                    item.EmployeesCount
                    ));
            }

            var w = ctx.jobs.GroupJoin(
                ctx.employee,
                x => x.job_id,
                x => x.job_id,
                (x, y) => new
                {
                    Job = x,
                    EmployeesCount = y.Count(),
                    Employees = y
                }).OrderBy(x => x.EmployeesCount).ThenBy(x => x.Job.job_desc);

            Console.WriteLine(w);
            q.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(15);
            foreach (var item in w)
            {
                Console.WriteLine(
                    string.Format(
                    "{0} - Number of employees: {1}",
                    item.Job.job_desc,
                    item.EmployeesCount
                    ));
            }
        }
    }
}
