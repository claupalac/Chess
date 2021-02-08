using System;
using Chess;
using Xunit;

namespace TestChess
{
    public class ChessTableTest
    {
        
        
        [Fact]
        void GetColumnLimit_WithPositiveColumnLimit_ShouldReturnSameValue()
        {
            ChessTable chessTable = new ChessTable(8, 8);
            int expected = 8;

            int actual = chessTable.GetColumnLimit();

            Assert.Equal(expected, actual);
        }
    }

}