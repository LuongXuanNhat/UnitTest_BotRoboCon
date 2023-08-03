namespace TreeTest
{
    public class Branch
    {
        public List<Leaf> leafss { get; set; }
        public List<Branch> branchss { get; set; }
        
        public Branch() {
        
        }

        public int SumLeavesInBranch()
        {
            if (this.branchss == null) return leafss.Count;
            else
            {
                var sumleaf = 0;
                foreach (var item in this.branchss)
                {
                    sumleaf += item.SumLeavesInBranch();
                }
                return sumleaf + leafss.Count;
            }
        }
    }
}