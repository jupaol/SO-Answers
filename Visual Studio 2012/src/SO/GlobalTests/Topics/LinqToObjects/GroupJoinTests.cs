using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalTests.Model;
using System.Linq;
using System.Collections.Generic;
using GlobalTests.Data;
using FluentAssertions;

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
    }
}
