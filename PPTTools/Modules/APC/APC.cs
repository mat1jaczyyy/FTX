﻿using System;
using System.IO;

namespace PPTTools {
    namespace Modules {
        public class APC: Module {
            private static readonly string ModuleIdentifier = "apc";

            private int currentSent, totalSent, currentCleared, totalCleared;

            public delegate void APCEventHandler(Decimal APC);
            public event APCEventHandler Changed;

            private void Raise() {
                if (Changed != null) {
                    if (totalCleared == 0) {
                        Changed.Invoke(0);
                    } else {
                        Changed.Invoke(Decimal.Divide(totalSent, totalCleared));
                    }
                }
            }

            public void Reset() {
                totalSent = totalCleared = 0;

                Raise();
            }

            public void Update() {
                int garbage = GameHelper.GarbageSent(GameHelper.GameState.playerIndex);

                if (garbage != currentSent) {
                    if (garbage > currentSent) {
                        totalSent += garbage - currentSent;
                    }

                    currentSent = garbage;
                }

                int lines = GameHelper.LinesCleared(GameHelper.GameState.playerIndex);

                if (lines != currentCleared) {
                    if (lines > currentCleared)
                        totalCleared += lines;

                    currentCleared = lines;
                }

                Raise();
            }

            public APC(): base(ModuleIdentifier) {
                Reset();
                Changed += Write;
            }

            private void Write(Decimal apc) {
                if (File.Exists(filename)) {
                    StreamWriter sw = new StreamWriter(filename);
                    sw.WriteLine(apc.ToString("0.000 APC"));
                    sw.Flush();
                    sw.Close();
                }
            }
        }
    }
}