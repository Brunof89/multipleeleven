using System;
using System.Collections.Generic;
using System.Text;

namespace NPF.MultipleEleven.Domain.Requests
{
    /// <summary>
    /// response class
    /// </summary>
    public class MultipleElevenResponseDto
    {
        public IEnumerable<MultipleElevenResultDto> result { get; set; }
    }

    public class MultipleElevenResultDto
    {
        public string number { get; set; }
        public bool isMultiple { get; set; }
    }
}
