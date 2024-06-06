using System.Drawing.Drawing2D;

namespace SDA_184knr_180knr_MyProject
{
    public partial class Form1 : Form
    {
        private Dictionary<int, HashSet<int>> network = new Dictionary<int, HashSet<int>>();
        private float zoom = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddComputer_Click(object sender, EventArgs e)
        {
            //Вземане на стойността на ID-то на компютъра от числовото поле
            int computerId = (int)numericUpDownComputerId.Value;

            //Проверка дали вече съществува такъв компютър с такова ID в мрежата
            if (!network.ContainsKey(computerId))
            {
                //Ако не съществува, новият компютър се добавя към мрежата
                network.Add(computerId, new HashSet<int>());
                //и се добавя в списъка с компютри
                listBoxComputers.Items.Add(computerId);
            }
            else
            {
                //Ако съществува се извежда съобщение за грешка
                MessageBox.Show("Computer with this ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveComputer_Click(object sender, EventArgs e)
        {
            //Проверява се дали е избран компютър от списъка с компютри
            if (listBoxComputers.SelectedIndex != -1)
            {
                //Ако е, компютърът се премахва от мрежата
                int computerId = (int)listBoxComputers.SelectedItem;
                network.Remove(computerId);
                listBoxComputers.Items.RemoveAt(listBoxComputers.SelectedIndex);

                //включително и връзките му с други компютри
                foreach (var connections in network.Values)
                {
                    connections.Remove(computerId);
                }

                //Също така, се изчистват връзките в списъка с връзки 
                listBoxConnections.Items.Clear();
                foreach (var item in network)
                {
                    foreach (var connection in item.Value)
                    {
                        if (connection > item.Key)
                        {
                            listBoxConnections.Items.Add($"{item.Key} <-> {connection}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a computer to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddConnection_Click(object sender, EventArgs e)
        {
            //Вземат се ID-тата на двата компютъра от съответните числови полета
            int computer1 = (int)numericUpDownComputer1.Value;
            int computer2 = (int)numericUpDownComputer2.Value;

            //Проверява се дали и двата компютъра съществуват в мрежата
            if (network.ContainsKey(computer1) && network.ContainsKey(computer2))
            {
                //и дали връзката вече не съществува
                if (!network[computer1].Contains(computer2))
                {
                    //Ако всичко е наред, връзката се добавя както за първия, така и за втория компютър, и се добавя в списъка с връзки
                    network[computer1].Add(computer2);
                    network[computer2].Add(computer1);
                    listBoxConnections.Items.Add($"{computer1} <-> {computer2}");
                }
                else
                {
                    MessageBox.Show("Connection already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("One or both computers do not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveConnection_Click(object sender, EventArgs e)
        {
            //Проверява се дали е избрана връзка от списъка с връзки
            if (listBoxConnections.SelectedIndex != -1)
            {
                string connection = listBoxConnections.SelectedItem.ToString();
                string[] computers = connection.Split(new string[] { " <-> " }, StringSplitOptions.None);
                int computer1 = int.Parse(computers[0]);
                int computer2 = int.Parse(computers[1]);

                //Ако е, връзката се премахва както от първия, така и от втория компютър и се изчиства от списъка с връзки
                network[computer1].Remove(computer2);
                network[computer2].Remove(computer1);
                listBoxConnections.Items.RemoveAt(listBoxConnections.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a connection to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDFS_Click(object sender, EventArgs e)
        {
            //Взима стойността на началния връх от числовото поле
            int startNode = (int)numericUpDownDFS.Value;

            //Проверка дали началният връх съществува в мрежата
            if (network.ContainsKey(startNode)) // Check if the starting node exists in the network
            {
                List<int> visited = new List<int>();
                DFS(startNode, visited);
                MessageBox.Show("DFS Traversal: " + string.Join(" -> ", visited), "DFS Traversal");
            }
            else
            {
                //Показване на съобщение за грешка, ако началният връх не съществува в мрежата
                MessageBox.Show("Starting node does not exist!", "Error");
            }
        }

        private void DFS(int node, List<int> visited)
        {
            visited.Add(node);
            foreach (int neighbor in network[node])
            {
                if (!visited.Contains(neighbor))
                {
                    DFS(neighbor, visited);
                }
            }
        }

        //Работи подобно на BtnDFS_Click
        private void BtnBFS_Click(object sender, EventArgs e)
        {
            int startNode = (int)numericUpDownBFS.Value;

            if (network.ContainsKey(startNode)) // Check if the starting node exists in the network
            {
                List<int> visited = BFS(startNode);
                MessageBox.Show("BFS Traversal: " + string.Join(" -> ", visited), "BFS Traversal");
            }
            else
            {
                MessageBox.Show("Starting node does not exist!", "Error");
            }
        }

        private List<int> BFS(int startNode)
        {
            List<int> visited = new List<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> processed = new HashSet<int>();

            queue.Enqueue(startNode);
            processed.Add(startNode);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                visited.Add(node);

                foreach (var neighbor in network[node])
                {
                    if (!processed.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        processed.Add(neighbor);
                    }
                }
            }

            return visited;
        }

        private void BtnShortestPath_Click(object sender, EventArgs e)
        {
            int source = (int)numericUpDownShortestPathSource.Value;
            int destination = (int)numericUpDownShortestPathDestination.Value;

            if (network.ContainsKey(source) && network.ContainsKey(destination))
            {
                List<int> shortestPath = FindShortestPath(source, destination);

                if (shortestPath.Count > 0)
                {
                    MessageBox.Show($"Shortest Path from {source} to {destination}: " + string.Join(" -> ", shortestPath), "Shortest Path");
                }
                else
                {
                    MessageBox.Show($"There is no path from {source} to {destination}!", "Shortest Path");
                }
            }
            else
            {
                MessageBox.Show("One or both of the nodes do not exist!", "Error");
            }
        }

        private List<int> FindShortestPath(int source, int destination)
        {
            Dictionary<int, int> previous = new Dictionary<int, int>();
            Dictionary<int, int> distance = new Dictionary<int, int>();

            HashSet<int> unvisited = new HashSet<int>(network.Keys);

            foreach (int node in network.Keys)
            {
                distance[node] = int.MaxValue;
            }

            distance[source] = 0;

            while (unvisited.Count > 0)
            {
                int current = unvisited.OrderBy(node => distance[node]).First();
                unvisited.Remove(current);

                foreach (int neighbor in network[current])
                {
                    int alt = distance[current] + 1;
                    if (alt < distance[neighbor])
                    {
                        distance[neighbor] = alt;
                        previous[neighbor] = current;
                    }
                }
            }

            List<int> path = new List<int>();

            int temp = destination;
            while (previous.ContainsKey(temp))
            {
                path.Insert(0, temp);
                temp = previous[temp];
            }
            path.Insert(0, source);

            return path;
        }

        private void BtnDrawGraph_Click(object sender, EventArgs e)
        {
            //Изчиства текущия граф
            network.Clear();
            listBoxComputers.Items.Clear();


            // Обхожда връзките в списъка listBoxConnections.Items и ги добавя към графа
            foreach (string connection in listBoxConnections.Items)
            {
                string[] connectionParts = connection.Split(new string[] { " <-> " }, StringSplitOptions.None);
                int sourceId = int.Parse(connectionParts[0]);
                int destinationId = int.Parse(connectionParts[1]);

                //Проверява дали началният връх не е вече добавен към графа
                if (!network.ContainsKey(sourceId))
                {
                    //Ако не е, добавя началния връх към графа и към списъка с компютрите
                    network.Add(sourceId, new HashSet<int>());
                    listBoxComputers.Items.Add(sourceId);
                }

                //Проверява дали крайния връх не е вече добавен към графа
                if (!network.ContainsKey(destinationId))
                {
                    network.Add(destinationId, new HashSet<int>());
                    listBoxComputers.Items.Add(destinationId);
                }
            }

            foreach (string connection in listBoxConnections.Items)
            {
                string[] connectionParts = connection.Split(new string[] { " <-> " }, StringSplitOptions.None);
                int sourceId = int.Parse(connectionParts[0]);
                int destinationId = int.Parse(connectionParts[1]);

                //Проверява дали връзката вече не е добавена към графа
                if (!network[sourceId].Contains(destinationId))
                {
                    //Ако не е, добавя връзката между началния и краен връх
                    network[sourceId].Add(destinationId);
                    network[destinationId].Add(sourceId);
                }
            }

            //Създаване на ново изображение с размери, умножени по zoom фактора
            Bitmap bitmap = new Bitmap((int)(pictureBoxGraph.Width * zoom), (int)(pictureBoxGraph.Height * zoom));
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            int margin = 70;
            int nodeRadius = 10;
            int width = (int)((pictureBoxGraph.Width - 2 * margin) * zoom);
            int height = (int)((pictureBoxGraph.Height - 2 * margin) * zoom);

            //Извиква метода за рисуване на графа
            DrawGraph(g, margin, nodeRadius, width, height);

            //Показва изображението на графа в PictureBox контрола
            pictureBoxGraph.Image = bitmap;
            //Освобождава ресурсите на графичния обект
            g.Dispose();
        }

        private void DrawGraph(Graphics g, int margin, int nodeRadius, int width, int height)
        {
            Dictionary<int, Point> nodePositions = new Dictionary<int, Point>();

            int rowLength = (int)Math.Sqrt(network.Count);
            if (rowLength <= 1)
            {
                rowLength = 2;
                width = width / 2;
                height = height / 2;
            }

            for (int i = 0; i < listBoxComputers.Items.Count; i++)
            {
                int x = margin + ((i % rowLength) * (width - margin * 2) / (rowLength - 1));
                int y = margin + ((i / rowLength) * (height - margin * 2) / (rowLength - 1));

                nodePositions.Add((int)listBoxComputers.Items[i], new Point((int)(x * zoom), (int)(y * zoom)));
            }

            foreach (var node in network)
            {
                int x1 = nodePositions[node.Key].X;
                int y1 = nodePositions[node.Key].Y;

                foreach (var neighbor in node.Value)
                {
                    int x2 = nodePositions[neighbor].X;
                    int y2 = nodePositions[neighbor].Y;

                    g.DrawLine(Pens.Black, x1, y1, x2, y2);
                }
            }

            foreach (var node in network)
            {
                int x = nodePositions[node.Key].X;
                int y = nodePositions[node.Key].Y;

                g.FillEllipse(Brushes.LightBlue, x - nodeRadius, y - nodeRadius, nodeRadius * 2, nodeRadius * 2);
                g.DrawString(node.Key.ToString(), new Font("Arial", 8), Brushes.Black, x - nodeRadius, y - nodeRadius - 20);
            }
        }

        private void TrackBarZoom_Scroll(object sender, EventArgs e)
        {
            zoom = (float)trackBarZoom.Value / 100;
            pictureBoxGraph.Invalidate();
        }
    }
}