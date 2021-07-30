using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using DemoLibrary.Models;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Tim", LastName = "Corey" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains(newPerson, people);
        }

        [Theory]
        [InlineData("Tim", "", "LastName")]
        [InlineData("", "Corey", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }

        [Fact]
        public void ConvertModelsToCSV_ShouldWork()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Tim", LastName = "Corey" };
            List<PersonModel> people = new List<PersonModel>();
            people.Add(newPerson);
            List<string> csvPeople = DataAccess.ConvertModelsToCSV(people);

            Assert.True(csvPeople.Count == 1);
            Assert.Contains("Tim,Corey", csvPeople);
        }

        [Theory]
        [InlineData("Tim Corey","Tim,Corey")]
        public void SplittingCSVToPersonModel_ShouldWork(string person, string csvLine)
        {
            List<PersonModel> people = new List<PersonModel>();
            string[] content = new string[1];
            content[0] = csvLine;
            DataAccess.SplittingCSVToPersonModel(people, content);

            Assert.True(people.Count == 1);
            Assert.Equal(person, people[0].FullName);
        }
    }
}
