using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperTest
{
    public class DecimalToStringConverter : ITypeConverter<decimal, string>
    {
        public string Convert(decimal source, string destination, ResolutionContext context)
        {
            return $"{source} zł";
        }
    }
}
