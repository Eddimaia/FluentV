﻿using FluentV.Core.Patterns;
using System;

namespace FluentV.Core.Validations
{
    public partial class ValidationRules<TEntity>
    {
        public ValidationRules<TEntity> NotWhiteSpace(string message = null)
        {
            if (_memberInFocusType != typeof(string))
                return this;


            var rule = new Rule
            {
                Message = message ?? $"'{_memberInFocus}' {DefaultMessage.WhiteSpace}"
            };

            rule.AcceptedValues.Add("Value that are not white spaces");

            _rules[_memberInFocus].Add(rule);

            return this;
        }
    }
}