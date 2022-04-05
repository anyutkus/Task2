using System;

var l1 = new Lection(topic:"topic 1");
var pr1 = new PracticalLesson("description 1", "Condition 1", "Solution 1");
var pr2 = new PracticalLesson();
var tr = new Training(pr2, pr1);

Console.WriteLine(tr.IsPractical());

tr.Add(l1);

Console.WriteLine(tr.IsPractical());