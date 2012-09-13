using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalTests.Data;
using System.Linq;
using GlobalTests.Model;
using FluentAssertions;

namespace GlobalTests.Topics.LinqToObjects
{
    [TestClass]
    public class FilterACollectionExcludingTheValuesFromAnotherCollectionTests
    {
        [TestMethod]
        public void it_should_return_all_values_from_the_original_collection_except_the_values_contained_in_the_second_collection()
        {
            var secretUsers = new[] { "Paul", "Jhon" };
            var allUsers = new DataRepositoryDummy().GetPeopleWithPets().ToList();

            allUsers.Add(new Person { Age = 12, LanguagesSpoken = Enumerable.Empty<Language>(), Name = "Jhon" });

            var q = allUsers.Select(x => x.Name).Distinct().Except(secretUsers);
            q.Should().HaveCount(3);
            q.Should().OnlyHaveUniqueItems();

            // alternate example 1
            var q1 = (from u in allUsers
                      from s in secretUsers
                      where u.Name == s
                      select u).Distinct();
            var q11 = allUsers.Except(q1);
            q11.Should().HaveCount(3);
            q11.Should().OnlyHaveUniqueItems();

            // alternate example 2 - does not work
            //var q2 = (from u in allUsers
            //          from s in secretUsers
            //          where u.Name != s
            //          select u).Distinct();
            //q2.Should().HaveCount(3);
            //q2.Should().OnlyHaveUniqueItems();
        }
    }
}
