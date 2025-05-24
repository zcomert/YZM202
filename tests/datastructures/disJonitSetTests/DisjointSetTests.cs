using DataStructures.DisjointSet;

namespace Tests.DisjonitSetTests;

public class DisjointSetTests
{
    // Smoke test: Tests basic usage, unions, finds, and IEnumerable support.
    [Fact]
    public void Smoke_Test_DisJointSet()
    {
        var disjointSet = new DisjointSet<int>();

        for (int i = 1; i <= 7; i++)
        {
            disjointSet.MakeSet(i);
        }

        //IEnumerable test
        Assert.Equal(disjointSet.Count, disjointSet.Count());

        disjointSet.Union(1, 2);
        Assert.Equal(1, disjointSet.FindSet(2));

        disjointSet.Union(2, 3);
        Assert.Equal(1, disjointSet.FindSet(3));

        disjointSet.Union(4, 5);
        Assert.Equal(4, disjointSet.FindSet(4));

        disjointSet.Union(5, 6);
        Assert.Equal(4, disjointSet.FindSet(5));

        disjointSet.Union(6, 7);
        Assert.Equal(4, disjointSet.FindSet(6));

        Assert.Equal(4, disjointSet.FindSet(4));
        disjointSet.Union(3, 4);
        Assert.Equal(1, disjointSet.FindSet(4));

        //IEnumerable test
        Assert.Equal(disjointSet.Count, disjointSet.Count());

    }
    // Tests that MakeSet creates unique sets for each element.
    [Fact]
    public void MakeSet_Should_Create_Unique_Sets()
    {
        var ds = new DisjointSet<string>();

        ds.MakeSet("A");
        ds.MakeSet("B");

        Assert.Equal("A", ds.FindSet("A"));
        Assert.Equal("B", ds.FindSet("B"));
        Assert.NotEqual(ds.FindSet("A"), ds.FindSet("B"));
        Assert.Equal(2, ds.Count);
    }

    // Tests that Union merges sets and FindSet returns the correct root.
    [Fact]
    public void Union_Should_Merge_Sets_Correctly()
    {
        var ds = new DisjointSet<int>();
        ds.MakeSet(10);
        ds.MakeSet(20);
        ds.MakeSet(30);

        ds.Union(10, 20);

        var root1 = ds.FindSet(10);
        var root2 = ds.FindSet(20);
        Assert.Equal(root1, root2); // 10 ve 20 aynı kümeye ait olmalı

        ds.Union(20, 30);
        var root3 = ds.FindSet(30);
        Assert.Equal(root1, root3); // 10, 20, 30 aynı kümede

        // Başta 3 küme vardı, şimdi birleştiler, 1 küme kalmalı
        Assert.Equal(3, ds.Count); // MakeSet ile oluşturulan toplam eleman sayısıdır
    }

    // Tests that Union decreases the number of disjoint sets.
    [Fact]
    public void Union_Should_Decrease_Number_Of_Sets()
    {
        var ds = new DisjointSet<int>();
        for (int i = 1; i <= 4; i++) ds.MakeSet(i);

        Assert.Equal(4, ds.GetSetCount());

        ds.Union(1, 2);
        Assert.Equal(3, ds.GetSetCount());

        ds.Union(3, 4);
        Assert.Equal(2, ds.GetSetCount());

        ds.Union(1, 4);
        Assert.Equal(1, ds.GetSetCount());
    }

    // Tests that FindSet throws if the element is not present.
    [Fact]
    public void FindSet_Should_Throw_If_Element_Not_Found()
    {
        var ds = new DisjointSet<int>();
        ds.MakeSet(1);

        var ex = Assert.Throws<Exception>(() => ds.FindSet(999));
        Assert.Equal("The value is not in this set!", ex.Message);
    }

    // Tests that MakeSet throws when adding a duplicate element.
    [Fact]
    public void MakeSet_Should_Throw_When_Adding_Duplicate()
    {
        var ds = new DisjointSet<int>();
        ds.MakeSet(42);

        var ex = Assert.Throws<Exception>(() => ds.MakeSet(42));
        Assert.Equal("The value has already been defined.", ex.Message);
    }

    // Tests that Union throws ArgumentNullException if either argument is null.
    [Fact]
    public void Union_Should_Throw_When_Null_Input()
    {
        var ds = new DisjointSet<string>();
        ds.MakeSet("A");
        ds.MakeSet("B");

        Assert.Throws<ArgumentNullException>(() => ds.Union("A", null));
        Assert.Throws<ArgumentNullException>(() => ds.Union(null, "B"));
    }

    // Tests that Union does not change the set count if the elements are already in the same set.
    [Fact]
    public void Union_Should_Not_Change_If_Same_Set()
    {
        var ds = new DisjointSet<int>();
        ds.MakeSet(1);
        ds.MakeSet(2);

        ds.Union(1, 2);
        var beforeCount = ds.GetSetCount();

        ds.Union(1, 2); // Tekrar aynı kümeleri birleştiriyoruz
        var afterCount = ds.GetSetCount();

        Assert.Equal(beforeCount, afterCount); // Küme sayısı değişmemeli
    }

    // Tests that DisjointSet is iterable and contains all elements.
    [Fact]
    public void DisjointSet_Should_Be_Iterable()
    {
        var ds = new DisjointSet<char>(new[] { 'X', 'Y', 'Z' });

        var elements = ds.ToList();
        Assert.Contains('X', elements);
        Assert.Contains('Y', elements);
        Assert.Contains('Z', elements);
        Assert.Equal(3, elements.Count);
    }

    // Tests that the constructor initializes all elements as separate sets.
    [Fact]
    public void Constructor_Should_Initialize_All_Elements()
    {
        var items = new[] { 100, 200, 300, 400 };
        var ds = new DisjointSet<int>(items);

        Assert.Equal(items.Length, ds.Count);
        foreach (var item in items)
        {
            Assert.Equal(item, ds.FindSet(item));
        }
    }




}