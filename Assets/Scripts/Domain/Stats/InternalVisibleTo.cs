// テストコードからinternalを参照できるようにする
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Test.Domain.Stats")]
