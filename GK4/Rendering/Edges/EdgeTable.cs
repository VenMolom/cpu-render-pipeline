namespace GK4.Rendering.Edges
{
    internal class EdgeTable
    {
        private Edge[] edges = new Edge[3000];
        private int[] size = new int[3000];

        public int Count { get; private set; } = 0;

        public int FirstIndex { get; private set; } = int.MaxValue;

        public Edge this[int index]
        {
            get
            {
                Count -= size[index];
                return edges[index];
            }
        }

        public void AddEdge(Vertex v1, Vertex v2, bool perspectiveCorrection)
        {
            Edge edge;
            if (v1.ScreenPosition.Y > v2.ScreenPosition.Y)
            {
                edge = new Edge(v2, v1, perspectiveCorrection);
            }
            else
            {
                edge = new Edge(v1, v2, perspectiveCorrection);
            }

            if (float.IsInfinity(edge.D)) return;

            if (edge.Ymax == edge.Ymin) return;

            if (edge.Ymin < FirstIndex)
            {
                FirstIndex = edge.Ymin;
            }

            Count++;
            size[edge.Ymin]++;

            if (edges[edge.Ymin] == null)
            {
                edges[edge.Ymin] = edge;
                return;
            }

            if (edges[edge.Ymin].X > edge.X)
            {
                edge.Next = edges[edge.Ymin];
                edges[edge.Ymin] = edge;
                return;
            }

            var currentEdge = edges[edge.Ymin];
            while (currentEdge.Next != null && currentEdge.Next.X < edge.X)
            {
                currentEdge = currentEdge.Next;
            }
            edge.Next = currentEdge.Next;
            currentEdge.Next = edge;
        }
    }
}