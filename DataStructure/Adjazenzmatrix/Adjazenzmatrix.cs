namespace DataStructure.Adjazenzmatrix;

public class Adjazenzmatrix {
    public string[] NodeList { get; set; }
    public int[,] AdjacencyMatrix { get; set; }

    public Adjazenzmatrix(int size) {
        NodeList = new string[size];
        AdjacencyMatrix = new int[size, size];
    }

    public void AddNode(string data) {
        for (int i = 0; i < NodeList.Length; i++) {
            if (NodeList[i] is null) {
                NodeList[i] = data;
                return;
            }
        }
    }

    public void AddEdge(string from, string to, int weight = 1) {
        int fromIndex = GetIndex(from);
        int toIndex = GetIndex(to);
        AdjacencyMatrix[fromIndex, toIndex] = weight;
    }

    public int GetIndex(string n) {
        int index = -1;
        for (int i = 0; i < NodeList.Length; i++) {
            if (NodeList[i] == n) {
                index = i;
                return index;
            }
        }

        return index;
    }

    public void PrintWeightMatrix() {
        Console.Write("\t");
        foreach (var s in NodeList) {
            Console.Write(s + "\t");
        }

        Console.WriteLine();

        for (int i = 0; i < AdjacencyMatrix.GetLength(1); i++) {
            Console.Write(NodeList[i] + "\t");
            for (int j = 0; j < AdjacencyMatrix.GetLength(0); j++) {
                if (AdjacencyMatrix[i, j] != 0) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(AdjacencyMatrix[i, j] + "\t");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else {
                    Console.Write(AdjacencyMatrix[i, j] + "\t");
                }
            }

            Console.WriteLine();
        }
    }
}