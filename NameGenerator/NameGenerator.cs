using System;
using System.Collections.Generic;
using System.Text;

namespace namegenerator
{
    public class NameGenerator
    {
        private string _lastName;
        private string[] _firstNames;
        private List<string> _firstNameCombinations;

        public NameGenerator(string lastName, string firstName)
        {
            this._lastName = lastName.Trim();
            this._firstNames = firstName.Trim().Split(' ');
            this._firstNameCombinations = new List<string>();
        }

        public List<string> GenerateNames()
        {
            for (int i = 1; i <= _firstNames.Length; i++)
            {
                CompositionNames(string.Empty, i);
            }

            List<string> nameCombinations = new List<string>();
            for (int i = 0; i < _firstNameCombinations.Count; i++)
            {
                if ((_lastName.Length + 1 + _firstNameCombinations[i].Length) < 21)
                {
                    nameCombinations.Add(String.Format("{0} {1}", _lastName, _firstNameCombinations[i]).ToUpper());
                    nameCombinations.Add(String.Format("{0} {1}", _firstNameCombinations[i], _lastName).ToUpper());
                }
            }

            if (nameCombinations.Count == 0)
            {
                nameCombinations.Add(_lastName.ToUpper());
            }

            return nameCombinations;
        }

        private void CompositionNames(string result, int counter)
        {
            if (counter == 0)
                return;


            for (int j = 0; j < _firstNames.Length; j++)
            {
                StringBuilder stringBuilder = new StringBuilder(result);
                if (!result.Contains(string.Format("{0} ", _firstNames[j])))
                {
                    stringBuilder.Append(string.Format("{0} ", _firstNames[j]));
                }

                if (counter == 1)
                {
                    string finalName = stringBuilder.ToString().Trim();
                    if (!_firstNameCombinations.Contains(finalName))
                    {
                        _firstNameCombinations.Add(finalName);
                    }
                }
                CompositionNames(stringBuilder.ToString(), counter - 1);
            }
        }
    }
}