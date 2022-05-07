docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down up -d  //run in detached mode
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down up --build //this will build everything/call docker file for each project and will be interactive
docker ps -a
docker images

default uid/pwd for rabbitMq is guest and guest