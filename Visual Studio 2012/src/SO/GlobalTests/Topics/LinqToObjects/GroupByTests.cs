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
    }
}
