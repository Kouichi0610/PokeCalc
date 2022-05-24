// テストコードからinternalを参照できるようにする
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Test.Domain.DamageCalculator")]
[assembly: InternalsVisibleTo("Test.Domain.ForcePicker")]
[assembly: InternalsVisibleTo("Test.Domain.TypeCorrector")]
[assembly: InternalsVisibleTo("Test.Domain.TypeMatchCorrector")]
