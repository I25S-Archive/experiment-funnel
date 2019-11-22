./funnel ./scripts/test.fs

echo '\n'
echo  Starting to watch ./scripts/test.fs for changes...
echo '\n'

inotifywait -q -m -e modify --format %e ./scripts/test.fs |
while read events; do
    echo '\n'
    echo  File changed, executing...
    echo '\n'
    ./funnel ./scripts/test.fs
    echo '\n'
    echo  Script executed.
    echo  Starting to watch ./scripts/test.fs for changes...
    echo '\n'
done