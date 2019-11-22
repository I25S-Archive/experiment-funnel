FROM ubuntu:18.04
RUN apt-get update && apt-get install inotify-tools -y

WORKDIR /home/appuser/app/
COPY ./ .

RUN chmod +x ./funnel
RUN chmod +x ./watch.sh

CMD ./watch.sh