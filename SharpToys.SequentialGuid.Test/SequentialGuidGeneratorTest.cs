using Xunit.Abstractions;

namespace SharpToys.SequentialGuid.Test
{
    public class SequentialGuidGeneratorTest
    {
        private readonly ITestOutputHelper _output;

        public SequentialGuidGeneratorTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Create()
        {
            var generator = new SequentialGuidGenerator();

            for (int i = 0; i < 5; i++)
            {
                var guid = generator.Create(SequentialGuidType.SequentialAtEnd);
                _output.WriteLine(guid.ToString());
            }

        }
    }
}