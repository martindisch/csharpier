class Test
{
    public static implicit operator Test(string s)
    {
        return new Test();
    }
}
