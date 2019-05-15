# JustGiving Test

A big part of what we do at JustGiving is reclaim the Gift Aid on donations made to charities. This saves them a lot of time and processing overheads.

The calculation for gift aid is `[Donation Amount] * ( [TaxRate] / (100 - [TaxRate]) )`.

  * For unit testing we use NUnit and NSubstitute, these are already referenced in the projects, but feel free to use which ever framework you prefer.
  * All stories should be completed with an appropriate amount of testing.
  * Please create a public repo (GitHub, BitBucket, GitLab etc) and send us the link, make sure to commit regularly so we can see how you came up with the solution.
  * Remember to be RESTful.

## Story 1 - Gift Aid Calculator
* Create a calculator.
* Gift aid calculated at a tax rate of 20%.

## Story 2 - Endpoint

* Create an endpoint so that other services can access the calculation for Gift Aid.
* Use this swagger spec as the basis for your API
```yaml
swagger: '2.0'
info:
  title: Gift Aid Service
  version: 1.0.0
basePath: /api
schemes:
  - https
paths:
  /giftaid:
    get:
      summary: Get the amount of gift aid reclaimable for donation amount
      parameters:
        - in: query
          name: amount
          type: number
          required: true
      produces:
        - application/json
      responses:
        '200':
          description: OK
          schema:
            $ref: '#/definitions/GiftAidResponse'
definitions:
  GiftAidResponse:
    type: object
    required:
      - donationAmount
      - giftAidAmount
    properties:
      donationAmount:
        type: number
      giftAidAmount: 
        type: number
```

## Story 3 - Validation
* There are two validation rules: 
    * Minimum donation amount is £2.00.
    * Maximum donation amount is £100,000.00. 
* Add validation for these cases and any other validation / error handling you think is appropriate for this endpoint.
* Add appropriate tests and document the endpoint

## Story 4 - Storing Gift Aid Declarations

* When a user makes a donation with Gift Aid, we need to store information about the donor.
* We need to store: 
  * Name
  * Post Code
  * Donation Amount
* Add an endpoint for this.
* Mock a database or add a simple in-memory database (maybe LiteDB) to persist this data.
* Produce a unique id for the declaration.
* Return the declaration id and the gift aid amount in the reponse.
* Add appropriate tests and document the endpoint

Thanks for your time, we look forward to hearing from you!
