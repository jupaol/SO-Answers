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
    }
}
