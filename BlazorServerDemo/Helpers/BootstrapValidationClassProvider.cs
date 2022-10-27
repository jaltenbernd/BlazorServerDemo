﻿using Microsoft.AspNetCore.Components.Forms;


namespace BlazorServerDemo.Helpers
{
    public class BootstrapValidationClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var isValid = !editContext.GetValidationMessages(fieldIdentifier).Any();


            if(editContext.IsModified(fieldIdentifier))
            {
                return isValid ? "is-valid" : "is-invalid";
            }

            return isValid ? string.Empty : "is-invalid";
        }
    }
}
