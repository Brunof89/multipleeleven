﻿using NPF.MultipleEleven.Domain.Dto;
using NPF.MultipleEleven.Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NPF.MultipleEleven.Domain
{
    /// <summary>
    /// multiple eleven service class
    /// </summary>
    public class MultipleElevenService
    {
        public MultipleElevenService()
        {

        }

        /// <summary>
        /// check main entry method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public MultipleElevenResponseDto Check(MultipleElevenRequestDto request)
        {

            var result = request.numbers.Select(n => new MultipleElevenResultDto
            {
                isMultiple = IsMultipleEleven(n),
                number = n
            });

            return new MultipleElevenResponseDto { result = result };
        }
        /// <summary>
        /// checks if input is number and if it is multiple of eleven
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsMultipleEleven(string n)
        {
            if (!isNumber(n))
                return false;

            return Convert.ToInt32(n) % 11 == 0;

        }

        public bool isNumber(string s)
        {
            int aux = 0;
            return Int32.TryParse(s, out aux);
        }
    }
}
