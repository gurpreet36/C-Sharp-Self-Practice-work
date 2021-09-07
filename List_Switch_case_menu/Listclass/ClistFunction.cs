using System;
using List_Switch_case_menu.ListModels;
using System.Collections.Generic;
namespace List_Switch_case_menu.Listclass
{
    public class ClistFunction
    {
        List<ListModel> lobj;
        public ClistFunction()
        {
            lobj=new List<ListModel>();
        }
        public void addOrder(ListModel listModel)
        {

        }
        public void searchOrderList(ListModel listModel)
        {

        }
        public void removeOrderFromlist(ListModel listModel)
        {

        }
        public void updateOrderList(ListModel listModel)
        {

        }
        public void  totalPrice((List<ListModel> lobj)
        {

        }
        public void displayOrderList(List<ListModel> lobj)
        {
            int count=lobj.Count;
            if(count==0)
            {
                Console.WriteLine("There is no order in the list, pls order first!!!!");
            }
            else{
                int n=1;
                foreach(var i in lobj)
                {
                    n++;
                    i.oPrice=i.oPrice*i.oQty;
                    Console.WriteLine(N+")  "+i.oName+"    "+i.oQty+"    "+i.oId+"    "+i.oPrice);
                }
            }
            
        }
    }
}