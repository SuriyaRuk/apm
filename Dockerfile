FROM golang:1.19.2 as build

WORKDIR /app

COPY go.mod ./
COPY go.sum ./
RUN go mod download

COPY *.go ./

RUN CGO_ENABLED=0 go build -o /elastic-apm

FROM kong:3.0

USER root
COPY --from=build /elastic-apm /usr/local/bin/
USER kong
