
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using intern_sycare.Repositories;
using System.Linq;

namespace Project.Handler
{
    public class DataHandler : IDataHandler{

        List<Item> items = new List<Item>();

        sqldbcontext _applicationDataContext;

        public DataHandler(sqldbcontext datacontenxt)
        {
            this._applicationDataContext = datacontenxt;
        }

        public IEnumerable<Item> GetItems(){

            //items = new List<Item>(){
            //    new Item{id = Guid.NewGuid(),name="Item 1", quantity= 4, net_amount=10, gross_amount =15,description="Malaria Test 1", item_category="lab 1",item_unit = "Small", tax=0.21, discount=0.10},
            //    new Item{id = Guid.NewGuid(),name="Item 2" ,quantity= 5, net_amount=20, gross_amount =30,description="Fever Test 1", item_category="lab 2",item_unit = "Medium", tax=0.31, discount=0.15},
            //    new Item{id = Guid.NewGuid(),name="Item 3", quantity= 6, net_amount=30, gross_amount =45,description="Covid Test 1", item_category="lab 3",item_unit = "Large", tax=0.41, discount=0.20},
            //};
            items = this._applicationDataContext.Item.Where(p=> p.isdeleted == false).ToList();
            return items;
        }

        public IEnumerable<Item> GetAllItems(){
            items = this._applicationDataContext.Item.Where(p => p.isdeleted == false).ToList();
            return items;
        }

        public Item GetItem(string id)
        {
            Item gotten_item = this._applicationDataContext.Item.First(p => p.id == id);
            return gotten_item;
        }

        public void AddItem(Item item){
            this._applicationDataContext.Add(item);
            this._applicationDataContext.SaveChanges();
        }

        public void UpdateItem(string id, Item updateDetails){

            Item item_to_be_deleted = this._applicationDataContext.Item.First(p => p.id == id);
            item_to_be_deleted.name = updateDetails.item_category;
            item_to_be_deleted.quantity = updateDetails.quantity;
            item_to_be_deleted.net_amount = updateDetails.net_amount;
            item_to_be_deleted.gross_amount = updateDetails.gross_amount;
            item_to_be_deleted.description = updateDetails.description;
            item_to_be_deleted.item_category = updateDetails.item_category;
            item_to_be_deleted.item_unit = updateDetails.item_unit;
            item_to_be_deleted.tax = updateDetails.tax;
            item_to_be_deleted.discount = updateDetails.discount;
            this._applicationDataContext.SaveChanges();
        }
        public void DeleteItem(string id){
            Item item_to_be_deleted = this._applicationDataContext.Item.First(p => p.id == id);
            item_to_be_deleted.isdeleted = true;
            this._applicationDataContext.SaveChanges();
        }
    }
}