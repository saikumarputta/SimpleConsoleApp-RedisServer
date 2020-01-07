# SimpleConsoleApp-RedisServer
simple console app that hits the redis server


#docker
docker pull redis

#Run docker conatiner locally
docker run local-redis -p 6379:6379 -d redis:latest

docker ps

docker exec -it local-redis  /bin/bash

redis-cli

ping

set k1 sai

get k1

#ipconfig

Now open your cmd use docker Nat ip address to use the docker container when dealing with the different port other than the
default local port.
