using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLearnLists
{
    internal class ListItem
    {
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListItem()
        {
            Begin = null;
            End = null;
        }

        public void Insert(Item i)
        {
            if (IsEmpty())
            {
                Begin = i;
                End = i;
            }
            else
            {
                if (i.Value <= Begin.Value)
                {
                    InsertFirst(i);
                }
                else
                {
                    if (i.Value >= End.Value)
                    {
                        InsertLast(i);
                    }
                    else
                    {
                        InsertMiddle(i);
                    }
                }

            }
        }

        public void InsertLast(Item i)
        {
            End = i.Next;
            End = i;

        }

        public void InsertFirst(Item i)
        {
            i.Next = Begin;
            Begin = i;
        }


        //public bool Find(Item f)    PARA QUE????
        //{
        //    Item aux = Begin;
        //    while (aux.Next != null)
        //    {
        //        if(aux.Value == f.Value)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            aux = aux.Next;
        //        }
        //        return false;
        //    }
        //}

        public bool IsEmpty()
        {
            if (Begin == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void InsertMiddle(Item i)
        {
            Item aux = Begin;
            Item aux2 = Begin.Next;
            while (i.Value > aux2.Value)
            {
                aux = aux2;
                aux2 = aux2.Next;
            }
            i.Next = aux.Next;
            aux.Next = i;
            aux2 = aux.Next;
        }
        public void Print(Item i)
        {
            Item aux = Begin;
            if (IsEmpty())
            {
                Console.WriteLine("Essa lista está vazia. ");
            }
            else
            {
                if (Begin.Value == End.Value)
                {
                    Console.WriteLine("Lista: " + Begin.Value);
                }
                else
                {
                    Console.Write("Lista: ");
                    Item aux = Begin;
                    while (aux.Value != End.Value)
                    {
                        Console.Write(aux.Value + " ");
                        aux = aux.Next;

                    }
                    Console.Write(aux.Value);
                }
            }
        }
    }
}
