using UnityEngine;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System;

namespace Assets.MyScripts.Test
{
    class ExampleObservableCollection : MonoBehaviour
    {
        private sealed class User
        {
            public string FirstName { get; }
            public string LastName { get; }

            public User(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }

        public void Main()
        {
            ObservableCollection<User> users = new ObservableCollection<User>
            {
                new User("Roman", "Muratov"),
                new User("Igor", "Ivanov"),
                new User("Bitalik", "Petrov")
            };

            users.CollectionChanged += Users_CollectionChanged;

            users.Add(new User("Lera", "Petrova"));
            users.RemoveAt(1);
            users[0] = new User("Sveta", "Ivanova");

            foreach (User user in users)
            {
                Debug.Log(user.FirstName);
            }
        }

        private void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    User newUser = (User)e.NewItems[0];
                    Debug.Log($@"Добавлен новый объект: {newUser.FirstName}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    User oldUser = (User)e.OldItems[0];
                    Debug.Log($@"Удален объект: {oldUser.FirstName}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    User replacedUser = (User)e.OldItems[0];
                    User replacingUser = (User)e.NewItems[0];
                    Debug.Log($@"Объект {replacedUser.FirstName} заменен объектом {replacingUser.FirstName}");
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


    }
}
