import urllib.request
import json
import sys
import urllib.parse

sys.stdout.reconfigure(encoding='utf-8')

def search_github(query):
    url = f"https://api.github.com/search/repositories?q={urllib.parse.quote(query)}&sort=stars&order=desc"
    req = urllib.request.Request(url, headers={'User-Agent': 'Mozilla/5.0'})
    try:
        with urllib.request.urlopen(req) as response:
            data = json.loads(response.read())
            print(f"Results for '{query}':")
            for item in data.get('items', [])[:10]:
                desc = str(item.get('description') or "")[:100]
                print(f"- {item['html_url']}")
                print(f"  {desc.replace(chr(10), ' ')}")
            print("-" * 20)
    except Exception as e:
        print(f"Error searching {query}: {e}")

search_github("бот для игры android")  # Bot for android game
search_github("взлом игр android")     # Android game hacking
search_github("il2cpp game bot")       # IL2CPP unity game bot
search_github("android packet bot")    # Android packet-based bot
search_github("frida unity il2cpp")    # Frida Unity IL2CPP hooking
