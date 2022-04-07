using System;

namespace Bank
{
    public class Account {
        private string _name;
        private string _surname;
        
        public Account(string name, string surname) {
            _name = name;
            _surname = surname;
        }
        public string Name {
            get {
                return _name;
            }
            set {
                if(value == string.Empty) {
                    throw new Exception("Please inform a name.");
                }
                _name = value;
            }
        }

        public string Surname {
            get {
                return _surname;
            }
            set {
                if(value == string.Empty) {
                    throw new Exception("Please inform a surname.");
                }
                _surname = value;
            }
        }
    }
}