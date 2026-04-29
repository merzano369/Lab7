namespace Lab7;

public class LinkedList
{
    private Node? _head;
    private Node? _tail;
    private int _count;

    public Node? Head => _head;

    public int Count => _count;

    public LinkedList()
    {
        _head = null;
        _tail = null;
        _count = 0;
    }

    public void AddFirst(short value)
    {
        Node newNode = new Node(value);
        newNode.Next = _head;
        _head = newNode;

        if (_tail == null)
            _tail = newNode;

        _count++;
    }

    public void InsertAfterFirst(short value)
    {
        if (_head == null)
        {
            AddFirst(value);
            return;
        }

        Node newNode = new Node(value);
        newNode.Next = _head.Next;
        _head.Next = newNode;

        if (_tail == _head)
            _tail = newNode;

        _count++;
    }

    public int FindFirstGreaterThan(short value)
    {
        int index = 0;
        Node? current = _head;

        while (current != null)
        {
            if (current.Value > value)
                return index;

            current = current.Next;
            index++;
        }

        return -1;
    }

    public double CalculateAverage()
    {
        if (_count == 0)
            return 0;

        int sum = 0;
        Node? current = _head;

        while (current != null)
        {
            sum += current.Value;
            current = current.Next;
        }

        return (double)sum / _count;
    }

    public (short value, int index) FindMax()
    {
        if (_head == null)
            return (0, -1);

        short maxValue = _head.Value;
        int maxIndex = 0;
        int currentIndex = 0;

        Node? current = _head;

        while (current != null)
        {
            if (current.Value > maxValue)
            {
                maxValue = current.Value;
                maxIndex = currentIndex;
            }

            current = current.Next;
            currentIndex++;
        }

        return (maxValue, maxIndex);
    }

    public int FindSumGreaterThanAverage()
    {
        if (_count == 0)
            return 0;

        double average = CalculateAverage();
        int sum = 0;
        Node? current = _head;

        while (current != null)
        {
            if (current.Value > average)
                sum += current.Value;

            current = current.Next;
        }

        return sum;
    }

    public LinkedList GetLessThanAverage()
    {
        LinkedList result = new LinkedList();

        if (_count == 0)
            return result;

        double average = CalculateAverage();
        Node? current = _head;

        while (current != null)
        {
            if (current.Value < average)
                result.AddLast(current.Value);

            current = current.Next;
        }

        return result;
    }

    public void RemoveAfterMax()
    {
        if (_head == null || _count <= 1)
            return;

        var (_, maxIndex) = FindMax();

        if (maxIndex == _count - 1)
            return;

        Node? current = _head;
        for (int i = 0; i < maxIndex; i++)
        {
            current = current?.Next;
        }

        if (current != null)
        {
            current.Next = null;
            _tail = current;
            _count = maxIndex + 1;
        }
    }

    public void AddLast(short value)
    {
        Node newNode = new Node(value);

        if (_tail == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }

        _count++;
    }

    public void Print()
    {
        if (_head == null)
        {
            Console.WriteLine("Список порожній");
            return;
        }

        Node? current = _head;
        while (current != null)
        {
            Console.Write(current.Value);
            if (current.Next != null)
                Console.Write(" -> ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public bool IsEmpty => _count == 0;
}