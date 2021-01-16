using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Memento
    {
        private readonly User savedUser;

        private Memento(User Usertosave)
        {
            savedUser = Usertosave.Clone();
        }

        public class Originator
        {
            private static User User;
            // The class could also contain additional data that is not part of the
            // state saved in the memento.

            public void Set(User state)
            {
                User = state;
            }

            public Memento SaveToMemento()
            {
                return new Memento(User);
            }

            public void RestoreFromMemento(Memento memento)
            {
                User.ID = memento.savedUser.ID;
                User.Username = memento.savedUser.Username;
                User.DateofBirth = memento.savedUser.DateofBirth;
                User.PhoneNum = memento.savedUser.PhoneNum;
                User.Email = memento.savedUser.Email;
            }
        }
    }
}