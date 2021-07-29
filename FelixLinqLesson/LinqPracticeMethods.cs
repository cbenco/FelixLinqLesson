using System;
using System.Collections.Generic;
using System.Linq;

namespace FelixLinqLesson
{
    public class LinqPracticeMethods
    {
        public static IEnumerable<string> GetOnlyUppercase(string input)
        {
            //Write a LINQ query which gets the words in the input which are all upper case.

            throw new NotImplementedException();
        }

        public static string GetLastWordContainingLowerCaseE(string sentence)
        {
            //Write a LINQ query which gets the alphabetically-last word that contains a lower case E
            //The result should be in the format "The last word is <word>".
            //If no words contain a lower case E, the result should be null.

            throw new NotImplementedException();
        }

        public static char GetMostFrequentCharacter(string input)
        {
            //Write a LINQ query which gets the most frequently occurring letter in the input
            //Upper and lower case letters are the same letter. Return the result in lower case.
            //If two letters have the same incidence, return the first alphabetically.

            throw new NotImplementedException();
        }

        public static IEnumerable<ProblemDetails> MapDbModelToExternalModel(IEnumerable<ErrorReport> errors)
        {
            //Write a LINQ query which takes the list of ErrorReports, and converts them to ProblemDetails.
            //Rules: Any code other than 200 is not a success
            //       If no external provider ID is given, it should default to -255.

            throw new NotImplementedException();
        }

        public static IEnumerable<Person> InterpolatePropertyFromAnotherList(IEnumerable<PersonModel> people, IEnumerable<PersonClass> classes)
        {
            //Write a LINQ query which maps a PersonModel to a Person.
            //Take their Class from a matching record in classes, if one exists. If not, consider them Lower class.
            //This should take place in O(n) time complexity.

            throw new NotImplementedException();
        }

        public static IEnumerable<Table> InterpolateListPropertyWithFilter(IEnumerable<TableModel> tables, IEnumerable<FieldModel> fields, Func<FieldModel, bool> filter)
        {
            //Write a LINQ query which maps TableModels to a Table.
            //Take only the fields which satisfy the filter.
            //If there are no fields found, the Fields property should contain an empty list.

            var fieldsLookup = fields.ToLookup(x => x.TableId);

            return tables.Select(x => new Table
            {
                Id = x.Id,
                Name = x.Name,
                Fields = fieldsLookup[x.Id].Where(filter).Select(y => new Field
                {
                    Id = y.Id,
                    Name = y.Name,
                    Type = y.Type
                })
            });
        }

        public static string WriteList(IEnumerable<object> inputs)
        {
            //Write a LINQ query that converts the input into a numbered list of strings
            //The entries should be in the format "1: Item 1" and each should be separated by a new line character

            throw new NotImplementedException();
        }

        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            //Write a LINQ query that checks whether each item in numbers
            //has a corresponding item in squares at the same index,
            //which is equal to the number's square.

            throw new NotImplementedException();
        }
    }
}
