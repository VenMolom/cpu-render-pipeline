using System.Collections.Generic;

namespace GK4.Rendering.Edges
{
    internal class ActiveEdgeTable
    {
        private Edge head = null;

        public bool Empty
        {
            get => head == null;
        }

        public void AddEdges(Edge edge)
        {
            var current = head;
            head = null;
            while (current != null)
            {
                var next = current.Next;
                AddEdge(current);
                current = next;
            }

            while (edge != null)
            {
                var next = edge.Next;
                AddEdge(edge);
                edge = next;
            }
        }

        public List<Range> GetFillRanges()
        {
            List<Range> ranges = new List<Range>();

            var edge = head;
            while (edge != null)
            {
                if (edge.Next == null) break;

                ranges.Add(new Range(edge, edge.Next));
                edge = edge.Next.Next;
            }

            return ranges;
        }

        public void Increase()
        {
            var edge = head;
            while (edge != null)
            {
                edge.Increase();
                edge = edge.Next;
            }
        }

        public void RemoveEdges(int y)
        {
            Edge newHead = null;
            var current = newHead;
            var edge = head;

            while (edge != null)
            {
                var next = edge.Next;
                edge.Next = null;
                if (edge.Ymax != y)
                {
                    if (newHead == null)
                    {
                        newHead = edge;
                        current = edge;
                        edge = next;
                        continue;
                    }

                    current.Next = edge;
                    current = edge;
                }
                edge = next;
            }

            head = newHead;
        }

        private void AddEdge(Edge edge)
        {
            if (edge == null) return;

            if (head == null)
            {
                head = edge;
                edge.Next = null;
                return;
            }

            if (edge.X < head.X)
            {
                edge.Next = head;
                head = edge;
                return;
            }

            var currentEdge = head;
            while (currentEdge.Next != null && currentEdge.Next.X < edge.X)
            {
                currentEdge = currentEdge.Next;
            }
            edge.Next = currentEdge.Next;
            currentEdge.Next = edge;
        }
    }
}