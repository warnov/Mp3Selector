from azure.cosmos import CosmosClient
import os

# Replace with your Cosmos DB account information
url = "https://cdb-mp3ranker.documents.azure.com:443/"
key = [KEY]

client = CosmosClient(url, credential=key)
database = client.get_database_client("dbMp3Ranker")
container = database.get_container_client("songs")

ranking_threshold = 70  # Set the desired ranking threshold value
query = f"SELECT c.Path, c.Values FROM c WHERE c.Values[0] > {ranking_threshold}"

song_with_artist_list = []

for item in container.query_items(query, enable_cross_partition_query=True):
    path_parts = item["Path"].split("\\")
    if len(path_parts) >= 4:
        song_with_artist = f"{path_parts[-1]} - {path_parts[1]}"
        song_with_artist_list.append(song_with_artist)

for song_with_artist in song_with_artist_list:
    print(song_with_artist)
