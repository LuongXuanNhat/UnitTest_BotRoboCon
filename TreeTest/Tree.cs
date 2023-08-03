namespace TreeTest
{
    public class Tree
    {
        public Tree()
        {
            branchs = new List<Branch>(); 
            leafs = new List<Leaf>();
        }

        public List<Branch> branchs { get; internal set; }
        public List<Leaf> leafs { get; internal set; }

        public bool IsHasTree()
        {
            return this != null;
        }

        public bool IsHasBranch()
        {
            return this.branchs != null;
        }

        public bool IsHasLeaf()
        {
            foreach (var branch in this.branchs)
            {
                if (branch.leafss.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int IsSumLeafTree()
        {
            return this.leafs.Count + this.SumLeavesInBranchs();
        }

        private int SumLeavesInBranchs()
        {
            var sumleaf = 0;
            foreach (var item in branchs)
            {
                sumleaf += item.SumLeavesInBranch();
            }
            return sumleaf;
        }
    }
}