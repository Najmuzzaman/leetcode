public class FoodRatings
{

    public SortedDictionary<string, SortedDictionary<int, List<string>>> foody = new SortedDictionary<string, SortedDictionary<int, List<string>>>();
        public SortedDictionary<string, Tuple<string, int>> foodtocosine =new SortedDictionary<string,Tuple<string,int>>();

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            int n = ratings.Length;
            for (int i = 0; i < n; i++)
            {
                if (!foody.ContainsKey(cuisines[i]))
                {
                    foody[cuisines[i]] = new SortedDictionary<int, List<string>>();
                    foody[cuisines[i]].Add(-1 * ratings[i], new List<string> { foods[i] });
                }
                else if (foody[cuisines[i]].ContainsKey(-1 * ratings[i]))
                {
                    foody[cuisines[i]][-1*ratings[i]].Add(foods[i]);
                } 
                else
                {
                    foody[cuisines[i]][-1 * ratings[i]] = new List<string>();
                    foody[cuisines[i]][-1 * ratings[i]].Add(foods[i]);
                }

                foodtocosine[foods[i]] = Tuple.Create(cuisines[i], -1*ratings[i]);
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            Tuple<string, int> Item = foodtocosine[food];
            foodtocosine.Remove(food);
            foodtocosine[food] = Tuple.Create(Item.Item1, -1 * newRating);
            if (foody[Item.Item1].ContainsKey(Item.Item2))
            {
                foody[Item.Item1][Item.Item2].Remove(food);
                if (foody[Item.Item1][Item.Item2].Count == 0)
                {
                    foody[Item.Item1].Remove(Item.Item2);
                }

                if (!foody[Item.Item1].ContainsKey(-1 * newRating))
                {
                    foody[Item.Item1][-1 * newRating] = new List<string>();
                }
                foody[Item.Item1][-1 * newRating].Add(food);
            }
        }

        public string HighestRated(string cuisine)
        {
            var highestRating = foody[cuisine].First();
            List<string> S = highestRating.Value;
            S.Sort();
            return S[0];
        }
}


/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */