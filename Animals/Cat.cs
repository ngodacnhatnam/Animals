﻿using System;
namespace Animals {
    public class Cat : Animal {
        public Cat(string name, string favoritefood) : base(name, favoritefood) {
            }
        public override string ExplainSelf() {
            return base.ExplainSelf() + Environment.NewLine + "MEOW";
            }
        }
    }
