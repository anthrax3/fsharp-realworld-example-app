﻿module RealWorld.Tests
open Expecto

[<EntryPoint>]
let main argv = 
  let allTests = [
    Integration.tests; 
    Articles.tests;
    Converter.tests;
  ]
  runTests defaultConfig (testList "All Tests" allTests)
