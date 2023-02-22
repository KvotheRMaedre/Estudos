using AprendendoDotNetTwitterInspired.Models;
using FluentValidation;
using System;

namespace AprendendoDotNetTwitterInspired.Validation
{
    public class TweetValidation : AbstractValidator<Tweet>
    {
        public TweetValidation() 
        {
            RuleFor(t => t.authorId)
                .NotNull().WithErrorCode("400").WithMessage("Id can't be null")
                .NotEmpty().WithErrorCode("400").WithMessage("Id can't be null");

            RuleFor(t => t.text)
                .NotNull().WithErrorCode("400").WithMessage("Text can't be null")
                .NotEmpty().WithErrorCode("400").WithMessage("Text can't be null")
                .MaximumLength(500).WithErrorCode("400").WithMessage("Text can't have more than 500 characters");

            /*RuleFor(t => t.dateEdited)
                .Equal(DateTime.Now).WithErrorCode("400").WithMessage("Edited date can't less or greater than today");*/

            RuleFor(t => t.likes)
                .GreaterThanOrEqualTo(0).WithErrorCode("400").WithMessage("Likes can't be less than 0");
        }
    }
}
