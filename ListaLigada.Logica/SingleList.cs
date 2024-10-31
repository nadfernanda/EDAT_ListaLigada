﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada.Logica
{
    public class SingleList<T>
    {
        private SingleNode<T>? _first;

        private SingleList()
        {
            _first = null;
        }

        public bool isEmpty => _first == null;

        public void Add(T item)
        {
            var node = new SingleNode<T>(item);

            if (isEmpty)
            {
                _first = node;
            }
            else
            {
                var pointer = _first;
                while (pointer!.Next != null)
                {
                    pointer = pointer.Next;
                }

                pointer.Next = node;
            }

        }

        public override string ToString()
        {
            var cadenaLista = String.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                cadenaLista += $"{pointer.Data}\n";

            }

            return cadenaLista.ToString();
            pointer = pointer.Next;
        }


    }
}