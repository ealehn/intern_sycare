
using intern_sycare.Repositories;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Project.Handler
{
    interface IDataHandler{

        IEnumerable<Item> GetItems();
        IEnumerable<Item> GetAllItems();

        Item GetItem(string id);

        void AddItem(Item item);
        void UpdateItem(string id, Item updateDetails);
        void DeleteItem(string id);
        
    }
}