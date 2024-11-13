

namespace ListaLigada.Logica
{
    public class SingleList<T>
    {
        private SingleNode<T>? _first;

        //lo cambie de private a public
        public SingleList()
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

        public bool Remove(T elemento) 
        {
            var previo = _first;
            var pointer = _first;

            while (pointer != null)
            {

                if (pointer.Data!.Equals(elemento)) 
                {

                    if (pointer == _first)
                    {
                        _first = pointer.Next;
                    }
                    else
                    {
                        previo!.Next = pointer.Next;

                    }
                    return true;
                }

                previo = pointer;
                pointer = pointer.Next;

            }
            
            return false;//si no encontro el elelemento
        }

        public override string ToString()
        {
            var cadenaLista = String.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                cadenaLista += $"{pointer.Data}\n";
                pointer = pointer.Next;
            }

            return cadenaLista.ToString();
           
        }


    }
}
