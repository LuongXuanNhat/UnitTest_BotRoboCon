namespace TreeTest
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void Is_has_tree_test()
        {
            var tree = new Tree();
            Assert.AreEqual(true, tree.IsHasTree());
        }

        [TestMethod]
        public void Is_has_branch_test()
        {
            var tree = new Tree();
            Assert.AreEqual(true, tree.IsHasTree());
            Assert.AreEqual(true, tree.IsHasBranch());
        }

        [TestMethod]
        public void Is_has_leaf_test()
        {
            Tree tree = new Tree()
            {
                branchs = new List<Branch>()
                {
                    new Branch()
                    {
                        leafss = new List<Leaf>()
                        {
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = "leaf 1", Color = null }
                        }
                    }
                }
            };
            
            Branch branch = tree.branchs[0];
            Leaf leaf = branch.leafss[0];

            Assert.AreEqual(true, tree.IsHasTree());
            Assert.AreEqual(true, tree.IsHasBranch());
            Assert.AreEqual(true, tree.IsHasLeaf());
        }

        [TestMethod]
        public void Is_sum_leaf_test()
        {
            Tree tree = new Tree()
            {
                branchs = new List<Branch>()
                {
                    new Branch()
                    {
                        branchss = new List<Branch>()
                        {
                            new Branch()
                            {
                                leafss = new List<Leaf>()
                                {
                                    new Leaf() { Name = null, Color = null },
                                    new Leaf() { Name = "leaf 1", Color = null }
                                }
                            },
                            new Branch()
                            {
                                branchss = new List<Branch>()
                                {
                                    new Branch()
                                    {
                                        leafss = new List<Leaf>()
                                        {
                                            new Leaf() { Name = null, Color = null },
                                            new Leaf() { Name = "leaf 1", Color = null }
                                        }
                                    },
                                    new Branch()
                                    {
                                        leafss = new List<Leaf>()
                                        {
                                            new Leaf() { Name = null, Color = null },
                                            new Leaf() { Name = null, Color = null },
                                            new Leaf() { Name = "leaf 1", Color = null }
                                        }
                                    },
                                }
                                ,
                                leafss = new List<Leaf>()
                                {
                                    new Leaf() { Name = null, Color = null },
                                    new Leaf() { Name = null, Color = null },
                                    new Leaf() { Name = "leaf 1", Color = null }
                                }
                            },
                        },
                        leafss = new List<Leaf>()
                        {
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = "leaf 1", Color = null }
                        }
                    },
                    new Branch()
                    {
                        leafss = new List<Leaf>()
                        {
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = "leaf 1", Color = null }
                        }
                    },
                    new Branch()
                    {
                        leafss = new List<Leaf>()
                        {
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = "leaf 1", Color = null }
                        }
                    },
                    new Branch()
                    {
                        branchss = new List<Branch>()
                        {
                            new Branch()
                            {
                                leafss = new List<Leaf>()
                                {
                                    new Leaf() { Name = null, Color = null },
                                    new Leaf() { Name = "leaf 1", Color = null },
                                    new Leaf() { Name = "leaf 1", Color = null }
                                }
                            },
                            new Branch()
                            {
                                leafss = new List<Leaf>()
                                {
                                    new Leaf() { Name = null, Color = null },
                                    new Leaf() { Name = null, Color = null },
                                    new Leaf() { Name = "leaf 1", Color = null }
                                }
                            },
                        }
                        ,
                        leafss = new List<Leaf>()
                        {
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = null, Color = null },
                            new Leaf() { Name = "leaf 1", Color = null }
                        }
                    },

                },
                leafs = new List<Leaf>()
                {
                    new Leaf() { Name = null, Color = null },
                    new Leaf() { Name = null, Color = null },
                    new Leaf() { Name = "leaf 1", Color = null }
                }

            };

            var sum_leaf_tree = tree.IsSumLeafTree();

            Assert.AreEqual(true, tree.IsHasTree());
            Assert.AreEqual(true, tree.IsHasBranch());
            Assert.AreEqual(true, tree.IsHasLeaf());
            Assert.AreEqual(30, sum_leaf_tree);
        }

    }
}