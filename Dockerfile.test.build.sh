docker build -f Dockerfile.test.build -t com-Shamiraa-service-purchasing-webapi:test-build .
docker create --name com-Shamiraa-service-purchasing-webapi-test-build com-Shamiraa-service-purchasing-webapi:test-build
mkdir bin
docker cp com-Shamiraa-service-purchasing-webapi-test-build:/out/. ./bin/publish
docker build -f Dockerfile.test -t com-Shamiraa-service-purchasing-webapi:test .
