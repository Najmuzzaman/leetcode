public class RandomizedSet {
    public List<int> list;
    public Dictionary<int, int> map;
    private Random rand;
    public RandomizedSet() {
        list = new List<int>();
        map = new Dictionary<int, int>();
        rand = new Random();
    }
  
    public bool Insert(int val) {
        if (Search(val)) return false;

        list.Add(val);
        map[val] = list.Count - 1;
        return true;
    }
    private bool Search(int val) {
        return map.ContainsKey(val);
    }
    public bool Remove(int val) {
      if (!Search(val)) return false;

        int index = map[val];
        list[index] = list[list.Count - 1];
        map[list[index]] = index;
        list.RemoveAt(list.Count - 1);
        map.Remove(val);

        return true;
    }
    
    public int GetRandom() {
        return list[rand.Next(list.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */