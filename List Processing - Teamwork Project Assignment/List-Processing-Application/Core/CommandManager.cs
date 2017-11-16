﻿using System.Collections.Generic;
using System.Linq;
using List_Processing_Application.Interfaces.Core;

namespace List_Processing_Application.Core
{
    public class CommandManager
    {
        public string Append(IList<string> args, string initial)
        {
            return initial + " " + args[0].ToString();
        }

        public string Prepend(IList<string> args, string initial)
        {
            var revesed = initial.Split(' ').Reverse().ToList();
            revesed.Add(args[0]);
            revesed.Reverse();
            return string.Join(" ", revesed);
        }

        public string Reverse(string initial)
        {
            var reversed = initial.Reverse().ToList();
            return reversed.ToString();
        }

        public string Insert(IList<string> args, string initial)
        {
            var index = int.Parse(args[0]);
            var arg = args[1];

            var list = initial.Split(' ').ToList();
            list.Insert(index, arg);
            return string.Join(" ", list);
        }

        public string Delete(IList<string> args, string initial)
        {
            var index = int.Parse(args[0]);

            if (index < 0 || index > initial.Length - 1)
            {
                return $"Error: invalid index {index}";
            }

            var list = initial.Split(' ').ToList();
            list.RemoveAt(index);

            return string.Join(" ", list);
        }

        public string RollLeft(string initial)
        {
            var list = initial.Split(' ').ToList();

            var listEnd = list.Count - 1;
            var shiftedElement = list[0];

            for (int i = 0; i < listEnd; i++)
            {
                list[i] = list[i + 1];
            }

            list[listEnd] = shiftedElement;

            return string.Join(" ", list);
        }

        public string RollRight(string initial)
        {
            var list = initial.Split(' ').ToList();

            var listEnd = list.Count - 1;
            var shiftedElement = list[listEnd];

            for (int i = listEnd; i > 0; i--)
            {
                list[i] = list[i - 1];
            }

            list[0] = shiftedElement;

            return string.Join(" ", list);
        }

        public string Sort(IList<string> args)
        {
            throw new System.NotImplementedException();
        }

        public string Count(IList<string> args)
        {
            throw new System.NotImplementedException();
        }

        public string End(object argList)
        {
            throw new System.NotImplementedException();
        }
    }
}