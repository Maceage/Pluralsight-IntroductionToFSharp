namespace System.ComponentModel.DataAnnotations

open System
open System.Collections.Generic

[<AttributeUsage(AttributeTargets.Property ||| 
                 AttributeTargets.Field ||| 
                 AttributeTargets.Parameter, 
                 AllowMultiple = false)>]
type EnumInvalidValueAttribute(invalidValue: obj) =
    inherit ValidationAttribute()

    override x.IsValid(v) = 
        not (EqualityComparer<uint64>.Default.Equals(
                Convert.ToUInt64(v), Convert.ToUInt64(invalidValue)))
        