using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalTests.Data;
using FluentAssertions;

namespace GlobalTests.Topics.LinqToObjects
{
    [TestClass]
    public class InnerJoinsTests
    {
        [TestMethod]
        public void testing_simple_inner_join_sentences()
        {
            var ctx = new PubsDataContext();

            var q = from e in ctx.employee
                    join j in ctx.jobs
                    on e.job_id equals j.job_id
                    orderby e.fname, e.lname, j.job_desc
                    select new
                    {
                        Employee = e,
                        Job = j
                    };

            q.Should().NotBeNull().And.NotBeEmpty();
            foreach (var item in q)
            {
                Console.WriteLine(item.Employee.fname + " " + item.Employee.lname + " With job: " + item.Job.job_desc);
            }

            var w = ctx.employee.Join(
                ctx.jobs,
                x => x.job_id,
                x => x.job_id,
                (x, y) => new
                {
                    Employee = x,
                    Job = y
                }).OrderBy(x => x.Employee.fname).ThenBy(x => x.Employee.lname).ThenBy(x => x.Job.job_desc);

            w.Should().NotBeNull().And.NotBeEmpty();
            foreach (var item in w)
            {
                Console.WriteLine(item.Employee.fname + " " + item.Employee.lname + " With job: " + item.Job.job_desc);
            }
        }
    }
}
