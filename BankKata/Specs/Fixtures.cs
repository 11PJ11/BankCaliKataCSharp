﻿namespace BankKata.Specs
 {
     public class BankAccountFixture : FeatureFixture
     {
         public BankAccountFixture() : base("BankAccount.txt") { }
     }
 }

 // Adding a new feature
 // (1) Create a feature file and set it as an Embedded Resource
 // (2) Create a fixture class that derives from FeatureFixture as above 