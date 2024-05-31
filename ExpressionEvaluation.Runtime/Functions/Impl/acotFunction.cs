﻿/*
    The MIT License

    Copyright (c) 2021 MathEval.org

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
*/
using ExpressionEvaluation.Runtime.Common;
using System;
using System.Collections.Generic;

namespace ExpressionEvaluation.Runtime.Functions
{
    /// <summary>
    /// ACOT(PI()/6) -> ~1.088448
    /// </summary>
    public class acotFunction : IFunction
    {
        /// <summary>
        /// Get Information
        /// </summary>
        /// <returns>FunctionDefs</returns>
        public List<FunctionDef> GetInfo()
        {
            return new List<FunctionDef>{
                    new FunctionDef(Afe_Common.Const_Acot, new System.Type[]{ typeof(decimal) }, typeof(decimal), 1)};
        }

        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="args">args</param>
        /// <param name="dc">dc</param>
        /// <returns>Value</returns>
        public Object Execute(Dictionary<string, Object> args, ExpressionContext dc)
        {
            Double result = Math.Atan(1d / Decimal.ToDouble(Afe_Common.ToDecimal(args[Afe_Common.Const_Key_One], dc.WorkingCulture)));
            return Convert.ToDecimal(result, dc.WorkingCulture);
            //return Afe_Common.Round(Math.Atan(1 / Decimal.ToDouble(Afe_Common.ToDecimal(args[Afe_Common.Const_Key_One]))), dc);
        }
    }
}
