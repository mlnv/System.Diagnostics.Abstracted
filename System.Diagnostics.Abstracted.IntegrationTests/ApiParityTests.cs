using Snapshooter;
using Snapshooter.Xunit;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace System.Diagnostics.Abstracted.IntegrationTests
{
    // Highly inspired on the implementation:
    // https://github.com/TestableIO/System.IO.Abstractions/blob/main/tests/System.IO.Abstractions.Tests/ApiParityTests.cs
    // License: https://github.com/TestableIO/System.IO.Abstractions/blob/main/LICENSE
    public class ApiParityTests
    {
#if NET6_0
        private const string snapshotSuffix = ".NET 6.0";
#else
#error Unknown target framework.
#endif

        [Fact]
        private void ApiParity_Process_ApiIsTheSame()
        {
            Compare(typeof(System.Diagnostics.Process), typeof(ProcessWrapper));
        }

        private void Compare(Type originalType, Type typeToCompare)
        {
            static IEnumerable<string> GetMembers(Type type) => type
                .GetMembers(Reflection.BindingFlags.Instance
                            | Reflection.BindingFlags.Static
                            | Reflection.BindingFlags.Public
                        | Reflection.BindingFlags.FlattenHierarchy)
                .Select(x => x.ToString())
                .OrderBy(x => x, StringComparer.Ordinal);

            var referenceMembers = GetMembers(originalType)
                .Select(x => x.Replace("System.Diagnostics.Process ", "System.Diagnostics.Abstracted.IProcess "))
                .Select(x => x.Replace("System.Diagnostics.Process[]", "System.Diagnostics.Abstracted.IProcess[]"));

            var abstractionMembers = GetMembers(typeToCompare);

            var diff = new ApiDiff(
                extraMembers: abstractionMembers.Except(referenceMembers),
                missingMembers: referenceMembers.Except(abstractionMembers)
            );

            Snapshot.Match(diff, SnapshotNameExtension.Create(snapshotSuffix));
        }

        private readonly struct ApiDiff
        {
            public string[] ExtraMembers { get; }
            public string[] MissingMembers { get; }

            public ApiDiff(IEnumerable<string> extraMembers, IEnumerable<string> missingMembers)
            {
                ExtraMembers = extraMembers.ToArray();
                MissingMembers = missingMembers.ToArray();
            }
        }
    }
}
