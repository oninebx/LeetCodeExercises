using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeExercises.Medium.RestoreIPAddresses
{
  public class Solution {
  public IList<string> RestoreIpAddresses(string s) {
        var result = new List<string>();
        var ip = string.Empty;
        BackTrack(s, 0, ip, result);
        return result;
    }

    private void BackTrack(string s, int n, string ip, IList<string> result){
        if(n == 4){
            if(string.IsNullOrEmpty(s)) {
                result.Add(ip);
                return;
            }
        }
        for(int i = 1;i < 4;i++){
            if(s.Length < i){
                break;
            }
            var section = int.Parse(s.Substring(0, i));
            if(section > 255 || i != section.ToString().Length){
                continue;
            }
            BackTrack(s.Substring(i),n + 1, $@"{ip}{section}{(n == 3 ? "": ".")}", result);
        }
    }
}
}