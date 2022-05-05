docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down up -d
docker ps
docker ps -a

default uid/pwd for rabbitMq is guest and guest