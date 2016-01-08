module Mace.Demo.Calculator.Tests

open Xunit

[<Fact>]
let adder_add_5_and_3_should_return_8() = 
    Assert.Equal(8, Adder.add 5 3)